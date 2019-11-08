using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Abp.Application.Services.Dto;
using Abp.Domain.Repositories;
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


        /* create a new player
         *     Annotation
         *     validation
         *          if player already exists or not
         *     formatting
         *     
         *     // Automapper 
         *     new player creation
         *     
         *     save new player to db
         *     
         *     if / else 
               
        */
        public async Task CreatePlayer(PlayerListItem input)
        {
            if (await _playerRepository.GetAll().AnyAsync(x => x.Email == input.Email))
                throw new UserFriendlyException("Already Existed");

            // validation for age verification      
            await _playerRepository.InsertAsync(ObjectMapper.Map<Player>(input));
        }

        public async Task DeletePlayer(int id) => await _playerRepository.DeleteAsync(id);


        // search by firstName, lastName, email , phone
        public async Task<ListResultDto<PlayerListItem>> GetAllPlayer(GetPlayerInput input)
        {
            // query  -  
            var playerLists = await _playerRepository
               .GetAll()
               .OrderByDescending(o => o.FirstName)
               .ToListAsync();

            return new ListResultDto<PlayerListItem>(ObjectMapper.Map<List<PlayerListItem>>(playerLists));

        }
        public async Task<PlayerListItem> GetPlayerById(int id) => ObjectMapper.Map<PlayerListItem>(await _playerRepository.GetAsync(id));

        // Unit of Work ( per request ) SaveChanges
        //  whatever changes you make will automatically get pushed to the db
        public async Task UpdatePlayer(PlayerListItem input)
        {
            var player = await _playerRepository.GetAsync(input.Id);
            var updatePlayer = player; // ObjectMapper.Map<Player>(input);
            updatePlayer.FirstName = input.FirstName;
            updatePlayer.LastName = input.LastName;
            //updatePlayer.PhoneNumber = input.PhoneNumber;
            updatePlayer.Email = input.Email;
            updatePlayer.DateOfBirth = input.DateOfBirth.ToString("MM/DD/YYY", CultureInfo.InvariantCulture);

        }
    }
}
