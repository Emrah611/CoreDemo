﻿using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICommentService
    {
        void CommentAdd(Comment comment);
        List<Comment> GetList(int id);

        //void CategoryDelete(Category category);
        //void CategoryUpdate(Category category);
        //Category GetById(int id);
    }
}
