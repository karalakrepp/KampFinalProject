﻿using Core.DataAccess.EntityFramework;
using DataAccessLayer.Abstract;
using EntityLayer.Concretes;
using EntityLayer.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete.EntityFramework;

public class EFProductDal : EfEntityRepositoryBase<Product,Context>,IProductDal
{
    //ReFactoring Code with DTO
    List<ProductDetalilDto> IProductDal.GetProductDetails()
    {
        using (Context context = new Context())
        {

            // Select table join anathor table
            var result = from p in context.Products
                         join c in context.Categories
                         on p.CategoryId equals c.CategoryId
                         select new ProductDetalilDto {ProductId=p.ProductId,
                             ProductName=p.ProductName,
                             CategoryName=c.CategoryName,
                             UnitsInStock=p.UnitsInStock };
            return result.ToList();
        }

        
        }
}

