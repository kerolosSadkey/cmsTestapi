

using SreamsCMSLF.Repositories;
using CmsStreams.Models.ModelsDto;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Mvc;
using AutoMapper;

namespace SreamsCMSLF.Controllers
{


    public class ManageUserController : ApiController
    {
        private readonly IUserRepository userRepository;
        private readonly IMapper mapper;
        public ManageUserController(IUserRepository _userRepository,IMapper _mapper)
        {
            this.userRepository = _userRepository;
            mapper = _mapper;   
        }

        [System.Web.Http.Route("api/user/GetAllUser")]
        public async Task<IHttpActionResult> GetUsers()
        {
            try
            {
                var users = await userRepository.GetUsers();
                var Organizations = await userRepository.GetOrganizations();
                if (users == null || Organizations == null)
                {
                    return NotFound();
                }
                else
                {
                      
                    return Ok(users);
                }
            }
            catch (Exception)
            {

                return StatusCode(System.Net.HttpStatusCode.InternalServerError);
            }

        }

       
        public async Task<string> GetMD5Hash(string password)

        {
            try
            {
                string mdf5str = await Task.Run(() => Helper.Encryptor.GetMD5Hash(password));
                if (mdf5str != null)
                {
                    return mdf5str;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception)
            {
                return "Error retrieving data from the database";

            }

        }



       
        public async Task<IHttpActionResult> Login(string userName, string password)
        {
            //password =await GetMD5Hash(password);
            try
            {

                var user = await userRepository.Login(userName, password);
                if (user == null)
                {
                    return NotFound();

                }
                else
                {
                    var Organization = await userRepository.GetOrganization(user.Id);
                    var userDtos = new UserDto()
                    {
                        Id = user.Id,
                        Address = user.Address,
                        Created_at = user.Created_at,
                        Date_birth = user.Date_birth,
                        Organization = Organization.Name,
                        Email = user.Email,
                        First_name = user.First_name,
                        Last_name = user.Last_name,
                        Middle_name = user.Middle_name,
                        Password = user.Password,
                        Phone_number = user.Phone_number,
                        Title = user.Title,
                        User_name = user.User_name,
                    };
                    return Ok(userDtos);

                }


            }
            catch (Exception)
            {
                return BadRequest();
            }

        }

      
        public async Task<IHttpActionResult> GetUserById(int Id)
        {
            try
            {
                var xuser = await userRepository.GetUser(Id);
                var Organization = await userRepository.GetOrganization(Id);

                if (xuser == null || Organization == null)
                {
                    return NotFound();
                }
                else
                {

                    var userDtos = new UserDto()
                    {
                        Id = xuser.Id,
                        Address = xuser.Address,
                        Created_at = xuser.Created_at,
                        Date_birth = xuser.Date_birth,
                        Organization = Organization.Name,
                        Email = xuser.Email,
                        First_name = xuser.First_name,
                        Last_name = xuser.Last_name,
                        Middle_name = xuser.Middle_name,
                        Password = xuser.Password,
                        Phone_number = xuser.Phone_number,
                        Title = xuser.Title,
                        User_name = xuser.User_name,
                    };
                    return Ok(userDtos);
                }
            }
            catch (Exception)
            {

                return StatusCode(System.Net.HttpStatusCode.InternalServerError);
            }

        }


    }
}
