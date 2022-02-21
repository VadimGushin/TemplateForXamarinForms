using MvvmCross;
using SQLite;
using SQLiteNetExtensions.Extensions;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using TemplateXamarinForms.Interfaces.Helpers;
using TemplateXamarinForms.Interfaces.SqlServices;

namespace TemplateXamarinForms.Services.SqlServices
{


    public class BaseSqlService<T> : IBaseSqlService<T> where T : class, new()
    {
        public SQLiteConnection DB;
        public BaseSqlService()
        {
            const string sqliteFilename = "DataBase.db3";
            var dbPath = Mvx.IoCProvider.Resolve<IDatabaseHelper>().GetPathDatabase();
            var path = Path.Combine(dbPath, sqliteFilename);
            DB = new SQLiteConnection(path);
            DB.CreateTable<T>();
        }

        public virtual bool Insert(T item)
        {
            try
            {
                DB.InsertOrReplaceWithChildren(item);
                return true;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                return false;
            }
        }

        public virtual bool Insert(IEnumerable<T> items)
        {
            try
            {
                DB.InsertOrReplaceAllWithChildren(items);
                return true;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                return false;
            }
        }

        public virtual IEnumerable<T> GetAll()
        {
            try
            {
                return DB.GetAllWithChildren<T>();
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                return default(IEnumerable<T>);
            }
        }



        public virtual bool Delete(T item)
        {
            try
            {
                var i = DB.Delete(item);
                return true;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                return false;
            }
        }

        public virtual bool Cleane()
        {
            try
            {
                var listAllElemets = DB.Table<T>().AsEnumerable();
                DB.DeleteAll(listAllElemets);
                return true;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                return false;
            }
        }

        public virtual bool Delete(IEnumerable<T> items)
        {
            try
            {
                DB.DeleteAll(items);
                return true;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                return false;
            }
        }

        public virtual bool Update(T item)
        {
            try
            {
                DB.UpdateWithChildren(item);
                return true;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                return false;
            }
        }

        public virtual bool Update(IEnumerable<T> items)
        {
            try
            {
                foreach (var item in items)
                {
                    DB.UpdateWithChildren(item);
                }
                return true;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                return false;
            }
        }
    }
}
