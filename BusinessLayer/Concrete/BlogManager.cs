﻿using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class BlogManager : IBlogService
    {
        IBlogDal _blogDal;

        public BlogManager(IBlogDal blogDal)
        {
            _blogDal = blogDal;
        }

        public void BlogAdd(Blog Blog)
        {
            throw new NotImplementedException();
        }

        public void BlogDelete(Blog Blog)
        {
            throw new NotImplementedException();
        }

        public void BlogUpdate(Blog Blog)
        {
            throw new NotImplementedException();
        }

        public List<Blog> GetBlogListWithCategory()
        {
            return _blogDal.GetListWithCategory();        
        }

        public Blog GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Blog> GetBlogByID(int id)
        {
            return _blogDal.GetList(x => x.BlogID == id);
        }

        public List<Blog> GetList()
        {
           return _blogDal.GetList();    
        }

        public List<Blog> GetBlogListByWriter(int id)
        {
            return _blogDal.GetList(x=>x.WriterID==id);
        }
    }
}
