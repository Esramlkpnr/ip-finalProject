//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FinalProject.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;

    public partial class Uye_giris
    {
        public int id { get; set; }
        [DisplayName("Kullanıcı Adı")]

        public string ad { get; set; }
        [DisplayName("Kullanıcı Soyadı")]

        public string soyad { get; set; }
        [DisplayName("Kullanıcı Maili")]

        [EmailAddress()]
        [MinLength(15, ErrorMessage = "Email Bilgisi En Az 15 karakter olmalıdır")]
        public string mail { get; set; }
        [DisplayName("Kullanıcı Şifre")]
        [DataType(DataType.Password)]
        [MinLength(6, ErrorMessage = "Şifre Bilgisi Minimum 6 karakter olmalıdır")]

        public string sifre { get; set; }
    }
}
