﻿using WebKoi6.DAL.Models;

namespace WebKoi6.Web.Areas.Admin.Models
{
    public class LichHenModel
    {
        public Lichhen? ObjLichhen {get; set;}
        public List<Donthuoc> ListDonthuoc { get; set;}
        public List<Chuandoanbenhcakoi> ListChuandoanbenhcakoi { get; set;}
        public List<Chuandoantinhtrangnuoc> ListChuandoantinhtrannuoc { get; set;}
    }
}