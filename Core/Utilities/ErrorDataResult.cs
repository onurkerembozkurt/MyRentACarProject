﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities
{
    public class ErrorDataResult<T>:DataResult<T>
    {
        public ErrorDataResult(T data,string message):base(data,false,message)
        {

        }
        public ErrorDataResult(T data):base(data,false)
        {
                //YILDIZ DEFAULT EGER HATA VERİRSE T DATA YAPIP DONDUR
        }
    }
}
