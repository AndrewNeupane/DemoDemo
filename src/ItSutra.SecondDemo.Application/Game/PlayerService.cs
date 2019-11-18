using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Abp.Application.Services.Dto;
using Abp.Domain.Repositories;
using Abp.Extensions;
using Abp.Linq.Extensions;
using Abp.UI;
using AutoMapper;
using ItSutra.SecondDemo.Game.Dto;
using ItSutra.SecondDemo.GameModel;
using Microsoft.EntityFrameworkCore;

namespace ItSutra.SecondDemo.Game
{
    public class PlayerService : SecondDemoAppServiceBase, IPlayerService
    {
        private readonly IRepository<Player> _playerRepository;


        public PlayerService(IRepository<Player> playerRepository)
        {
            _playerRepository = playerRepository;
        }
        public async Task CreatePlayer(PlayerListItem input)
        {
            if (await _playerRepository.GetAll().AnyAsync(x => x.Email == input.Email && Convert.ToInt32(input.DateOfBirth.Year - DateTime.Today.Year) < 18))
                throw new UserFriendlyException("Already Existed or Under Age");

            await _playerRepository.InsertAsync(ObjectMapper.Map<Player>(input));
        }

        public async Task DeletePlayer(int id) => await _playerRepository.DeleteAsync(id);

        public async Task<ListResultDto<PlayerListItem>> GetAllPlayer(GetPlayerInput input)
        {
            var playerLists = await _playerRepository
               .GetAll()
               .WhereIf(
                    !input.Filter.IsNullOrEmpty(),
                    s => s.FirstName.Contains(input.Filter) ||
                         s.LastName.Contains(input.Filter) ||
                         s.Email.Contains(input.Filter) ||
                         s.PhoneNumber.ToString().Contains(input.Filter)
                )
               .OrderBy(o => o.CreationTime)
               .ToListAsync();

            return new ListResultDto<PlayerListItem>(ObjectMapper.Map<List<PlayerListItem>>(playerLists));
        }
        public async Task<PlayerListItem> GetPlayerById(int id) => ObjectMapper.Map<PlayerListItem>(await _playerRepository.GetAsync(id));

        public async Task UpdatePlayer(PlayerListItem input)
        {
            var updatePlayer = await _playerRepository.GetAsync(input.Id);
            updatePlayer.FirstName = input.FirstName;
            updatePlayer.LastName = input.LastName;
            //updatePlayer.PhoneNumber = input.PhoneNumber;
            updatePlayer.Email = input.Email;
            updatePlayer.DateOfBirth = input.DateOfBirth.ToString("MM/DD/YYY", CultureInfo.InvariantCulture);

        }
    }
}
