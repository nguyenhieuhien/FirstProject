﻿using BusinessObjects.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessObjects
{
    public class CategoryDAO
    {
        private static CategoryDAO? instance = null;
        private static readonly object instanceLock = new object();
        private CategoryDAO() { }
        public static CategoryDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new CategoryDAO();
                    }
                    return instance;
                }
            }
        }

        public List<Category> GetAllCategory()
        {
            List<Category> categoryList = new List<Category>();
            try
            {
                using (FuflowerBouquetManagementV4Context context = new FuflowerBouquetManagementV4Context())
                {
                    categoryList = context.Categories.ToList();
                    return categoryList;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }

        public string GetCategoryNameById(int id)
        {
            try
            {
                using (FuflowerBouquetManagementV4Context context = new FuflowerBouquetManagementV4Context())
                {
                    return context.Categories.Find(id).CategoryName;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public int GetIdByName(string name)
        {
            try
            {
                using (FuflowerBouquetManagementV4Context? context = new FuflowerBouquetManagementV4Context())
                {
                    return context.Categories.FirstOrDefault(x => x.CategoryName.Equals(name)).CategoryId;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
