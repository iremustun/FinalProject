using System;
using System.Collections.Generic;
using System.Text;
using DCore.DataAccess;
using Entities.Concrete;
using Entities.DTOs;

namespace DataAccess.Abstract
{
    public interface IProductDal:IEntityRepository<Product>
    {
        List<ProductDetailDto> GetProductDetail();

    }
}
//code refactoring - kod iyileştirme