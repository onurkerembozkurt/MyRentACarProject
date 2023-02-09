using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfBrandDal :EfEntityRepositoryBase<Brand,CarRentDatabaseContext>,IBrandDal
    {
       
    }
}
/*
 *Using Kalıbı(IDispossible Patern implementions of C#)
 *Siz bi class ı newlediğinizde, garbage collector onu düzenli zamanla gelir ve bellekten atar
 *using kullanımı bittiğinde garbage collectore diyor ki beni gel hemen yok et çünkü context nesneleri
 *biraz pahalı
 */