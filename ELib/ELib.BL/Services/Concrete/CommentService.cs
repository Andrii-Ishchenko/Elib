﻿using System.Collections.Generic;
using System.Linq;
using ELib.BL.DtoEntities;
using ELib.BL.Services.Abstract;
using ELib.DAL.Infrastructure.Abstract;
using ELib.Domain.Entities;


namespace ELib.BL.Services.Concrete
{
    public class CommentService : BaseService<Comment, CommentDto>, ICommentService
    {
        public CommentService(IUnitOfWorkFactory factory)
            : base(factory)
        {
           
        }

        public List<CommentDto> GetCommentsByBookId(int id)
        {
            using (var uow = _factory.Create())
            {
                List<CommentDto> commentList = new List<CommentDto>();

                var Book = uow.Repository<Book>().GetById(id);
                if(Book == null)
                {
                    return null;
                }
                var Comments = uow.Repository<Comment>().Get(x => x.BookId==Book.Id).ToList();
                foreach (var item in Comments)
                {
                    var entityDto = AutoMapper.Mapper.Map<CommentDto>(item);
                    commentList.Add(entityDto);
                }
                return commentList;
            }
        }
   }
}