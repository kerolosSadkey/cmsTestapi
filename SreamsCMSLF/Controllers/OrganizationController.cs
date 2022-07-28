using AutoMapper;
using CmsStreams.Models.ModelsDto;
using SreamsCMSLF.Entities;
using SreamsCMSLF.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace SreamsCMSLF.Controllers
{

    [RoutePrefix("api/Organization")]
    public class OrganizationController : ApiController
    {

        private readonly IGenericRepository<Organization> organizationRepository;
        private readonly IUnitOfwork uintofwork;
        private readonly IMapper mapper;
        public OrganizationController(IUnitOfwork _uintofwork, IMapper _mapper)
        {
            uintofwork = _uintofwork;
            organizationRepository = uintofwork.Organization;
            mapper = _mapper;
        }


        [HttpGet]
        [Route("GetAllOrganization")]
        public async Task<IHttpActionResult> GetAllOrgainzation()
        {
            try {
                var organization = await Task.Run(() => organizationRepository.GetALL().ToList());

                if (organization != null)
                {
                    var orginaztionDto = organization.Select(mapper.Map<Organization, OrganizationDto>);
                    return Ok(orginaztionDto);
                }
                else
                {
                    return BadRequest();
                }

            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
          

            
           
        }



        [HttpPost]
        [Route("AddOrganization")]
        public async Task<IHttpActionResult> AddOrganization(OrganizationDto organizationDto)
        {

            try 
            {
                if (organizationDto == null)
                {
                    return NotFound();
                }
                else
                {
                    Organization organization = new Organization()
                    {
                        Name = organizationDto.Name,
                        Description = organizationDto.Description,
                        email = organizationDto.email,
                        Address = organizationDto.Address,
                        fax = organizationDto.fax,
                        landline = organizationDto.landline,
                        phone = organizationDto.phone,
                        logo = organizationDto.logo,
                        PerantId = organizationDto.PerantId,
                    };

                    organizationRepository.Add(organization);
                    uintofwork.Save();

                    return StatusCode(HttpStatusCode.OK);
                }
            }catch(Exception Ex)
            {
                return BadRequest(Ex.Message);
            }
           
        }


        [HttpGet]
        [Route("GetOrganizationById/{id}")]
        public async Task<IHttpActionResult> GetOrganizationById(int id)
        {
            try
            {
                var organization = await Task.Run(() => organizationRepository.FindById(id));

                if (organization != null)
                {
                    var orginaztionDto = mapper.Map<Organization, OrganizationDto>(organization);
                    return Ok(orginaztionDto);
                }
                else
                {
                    return BadRequest();
                }

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }




        }


        [HttpDelete]
        [Route("Deleteorganization/{id}")]
        public async Task<IHttpActionResult> Deleteorganization(int id)
        {
            try
            {
                var organization = await Task.Run(() => organizationRepository.FindById(id));

                if (organization != null)
                {
                        organizationRepository.Delete(organization);
                    uintofwork.Save();
                    return StatusCode(HttpStatusCode.OK);
                }
                else
                {
                    return BadRequest();
                }

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }


        }

        [HttpPut]
        [Route("UpdateOrganization")]
        public async Task<IHttpActionResult> UpdateOrganization(OrganizationDto organizationDto)
        {
            try
            {

                var organization = await Task.Run(() => organizationRepository.FindById(organizationDto.Id));


                organization.Name = organizationDto.Name;
                organization.email = organizationDto.email;
                organization.fax = organizationDto.fax;
                organization.landline = organizationDto.landline;
                organization.phone = organizationDto.phone;
                organization.Address = organization.Address;
                organization.PerantId = organizationDto.PerantId;
                organization.logo = organizationDto.logo;
                if (organization != null)
                {
                    organizationRepository.Update(organization);
                    uintofwork.Save();
                    return StatusCode(HttpStatusCode.OK);
                }
                else
                {
                    return BadRequest(404);
                }

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }


        }
    }
}
