﻿using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebBanThatLung.Models
{
    public class NguoiDungModel
    {
        [Key]
        public int ID_NGUOI_DUNG { get; set; }

        [Required(ErrorMessage = "Không được để trống họ và tên.")]
        [StringLength(40, MinimumLength = 5, ErrorMessage = "Họ tên phải từ 5 đến 40 ký tự.")]
      
        public string HO_TEN { get; set; }

        [Required(ErrorMessage = "Yêu cầu nhập số điện thoại")]
        [RegularExpression(@"^\d{10}$", ErrorMessage = "SDT phải là số và có 10 ký tự.")]
        public string SDT { get; set; }

        [Required(ErrorMessage = "Yêu cầu nhập CCCD")]
        [RegularExpression(@"^\d{12}$", ErrorMessage = "CCCD phải là số và có 12 ký tự.")]
        public string CCCD { get; set; }

        [Required(ErrorMessage = "Yêu cầu nhập Email")]
        [EmailAddress(ErrorMessage = "Định dạng Email không đúng")]
        public string EMAIL { get; set; }

        [Required(ErrorMessage = "Yêu cầu nhập tên tài khoản")]
        [MinLength(6, ErrorMessage = "Tên tài khoản phải có ít nhất 6 ký tự.")]
        public string TAI_KHOAN { get; set; }

        [Required(ErrorMessage = "Yêu cầu nhập mật khẩu")]
        [MinLength(6, ErrorMessage = "Mật khẩu phải có ít nhất 6 ký tự.")]
        [MaxLength(20, ErrorMessage = "Mật khẩu không được vượt quá 20 ký tự.")]
        public string MAT_KHAU { get; set; }

        public int VAI_TRO { get; set; } = 0;
        public string HINH_ANH { get; set; } = "User_images.jpg";
        public DateTime NGAY_TAO { get; set; } = DateTime.Now;
        public int TRANG_THAI { get; set; } = 0;
        public DateTime NGAY_SINH { get; set; } = DateTime.Now;
    }
}
