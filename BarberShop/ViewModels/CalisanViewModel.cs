﻿using BarberShop.Models;

namespace BarberShop.ViewModels
{
    public class CalisanViewModel
    {
        public int Id { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Telefon { get; set; }

        // Uzmanlık Alanları (Hizmetler)
        public List<int> SecilenHizmetler { get; set; } = new List<int>();
        public List<Hizmet> TumHizmetler { get; set; } = new List<Hizmet>();

        // Çalışma Saatleri
        public List<CalisanCalismaSaatiViewModel> CalismaSaatleri { get; set; } = new List<CalisanCalismaSaatiViewModel>();
    }
}