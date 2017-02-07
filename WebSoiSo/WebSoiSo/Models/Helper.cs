using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebSoiSo.Models
{
    public static class Helper
    {
        string ReplaceSoXo(string _so, string _do, string _xanh)
        {
            if (_do!="000000")
            {
                var i=0;
                var str="";
                foreach (var item in _so)
                {
                    if(_do[i]=='1')
                    {
                        str+="<h8>"+item+"</h8>";
                    }
                    else
                    {
                        str += item;
                    }
                }
                return str;
            }
            else if (_xanh!="000000")
            {
                var i = 0;
                var str = "";
                foreach (var item in _so)
                {
                    if (_xanh[i] == '1')
                    {
                        str += "<h7>" + item + "</h7>";
                    }
                    else
                    {
                        str += item;
                    }
                }
                return str;
            }
            else
            {
                return _so;
            }
        }
    }
}