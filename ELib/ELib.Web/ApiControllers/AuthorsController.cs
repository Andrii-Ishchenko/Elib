﻿using ELib.BL.DtoEntities;
using ELib.BL.Services.Abstract;
using ELib.Common;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ELib.Web.ApiControllers
{
    public class AuthorsController : ApiController
    {
        private readonly IAuthorService _authorService;
        private ELogger logger;

        public AuthorsController(IAuthorService authorService)
        {
            logger = ELoggerFactory.GetInstance().GetLogger(GetType().FullName);
            _authorService = authorService;
        }

        [HttpGet]
        public HttpResponseMessage GetAuthors()
        {
            try
            {
                IEnumerable<AuthorDto> authors = _authorService.GetAll();
                return Request.CreateResponse(HttpStatusCode.OK, authors);
            }
            catch (Exception ex)
            {
                
                logger.Error("Error In Author/Get",ex);
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }

        [HttpGet]
        public HttpResponseMessage GetAuthorById(int id)
        {
            try
            {
                AuthorDto authorDto = _authorService.GetById(id);
                return Request.CreateResponse(HttpStatusCode.OK, authorDto);
            }
            catch (Exception ex)
            {
                logger.Error("Error In Author/GetById",ex);
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }

        [HttpPut]
        public HttpResponseMessage AddAuthor(AuthorDto authorDto)
        {
            try
            {
                if (authorDto != null && ModelState.IsValid)
                {
                    _authorService.Insert(authorDto);
                    return Request.CreateResponse(HttpStatusCode.OK, "Ok");
                }
                return Request.CreateResponse(HttpStatusCode.BadRequest, "Model State Is Not Valid");
            }
            catch (Exception ex)
            {
                logger.Error("Error In Author/Add",ex);
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }

        [HttpPost]
        public HttpResponseMessage UpdateAuthor(AuthorDto authorDto)
        {
            try
            {
                if (authorDto != null && ModelState.IsValid)
                {
                    _authorService.Update(authorDto);
                    return Request.CreateResponse(HttpStatusCode.OK, "Ok");
                }
                return Request.CreateResponse(HttpStatusCode.BadRequest, "Model State Is Not Valid");
            }
            catch (Exception ex)
            {
                logger.Error("Error In Author/Update",ex);
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }

        [HttpDelete]
        public HttpResponseMessage DeleteAuthorById(int id)
        {
            try
            {
                _authorService.DeleteById(id);
                return Request.CreateResponse(HttpStatusCode.OK);
            }
            catch (Exception ex)
            {
                logger.Error("Error In Author/DeleteById",ex);
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }
    }
}
