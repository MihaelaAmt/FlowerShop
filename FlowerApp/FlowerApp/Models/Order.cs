﻿using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace FlowerApp.Models
{
    public class Order
    {
        [BindNever]
        public int OrderId { get; set; }

        public List<OrderDetail> OrderLines { get; set; }
        //message to add first name
        [Required(ErrorMessage = "Please enter your first name")]
        //permanently viewed
        [Display(Name = "First Name")]
        //max length
        [StringLength(50)]
        public string FirstName { get; set; }

        //message to add last name
        [Required(ErrorMessage = "Please enter your last name")]
        //permanently viewed
        [Display(Name = "Last Name")]
        //max length
        [StringLength(50)]
        public string LastName { get; set; }

        //shipping method
        [Required]
        //max legth
        [StringLength(50)]
        public string ShippingMethod { get; set; }

        //Address 
        //[Required(ErrorMessage = "Please enter your address")]
        [StringLength(100)]
        //permanently viewed
        [Display(Name = "Address Line 1")]
        public string AddressLine1 { get; set; }

        //permanently viewed
        [Display(Name = "Address Line 2")]
        public string AddressLine2 { get; set; }

        //[Required(ErrorMessage = "Please enter your zip code")]
        //permanently viewed
        [Display(Name = "Zip code")]
        //set min length
        [StringLength(10, MinimumLength = 4)]
        public string ZipCode { get; set; }

        //message to add city
        [Required(ErrorMessage = "Please enter your city")]
        //max length
        [StringLength(50)]
        public string City { get; set; }

        //max length
        [StringLength(10)]
        public string State { get; set; }

        //[Required(ErrorMessage = "Please enter your country")]
        //max length
        [StringLength(50)]
        public string Country { get; set; }

        //message to add phone number
        [Required(ErrorMessage = "Please enter your phone number")]
        //max length
        [StringLength(25)]
        [DataType(DataType.PhoneNumber)]
        [Display(Name = "Phone number")]
        public string PhoneNumber { get; set; }

        [Required]
        [StringLength(50)]
        [DataType(DataType.EmailAddress)]
        [RegularExpression(@"(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*|""(
                            ?:[\x01-\x08\x0b\x0c\x0e-\x1f\x21\x23-\x5b\x5d-\x7f]|\\[\x01-\x09\x0b\x0c\x0e-\x7f])*"")@(?:(?:
                            [a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?|\[
                            (?:(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\.){3}
                            (?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?|[a-z0-9-]*[a-z0-9]:(?:[\x01-\x08\x0b\x0c\x0e-\x1f\x21-\x5a\x53-\x7f]|\\
                            [\x01-\x09\x0b\x0c\x0e-\x7f])+)\])",
            ErrorMessage = "The email address is not entered in a correct format")]
        public string Email { get; set; }

        [BindNever]
        [ScaffoldColumn(false)]
        public decimal OrderTotal { get; set; }

        [BindNever]
        [ScaffoldColumn(false)]
        public DateTime OrderPlaced { get; set; }

        [Required]
        [StringLength(50)]
        public string PayMethod { get; set; }

        [StringLength(16)]
        public string CardNumber { get; set; }

        [StringLength(3)]
        public string SecurityCode { get; set; }
    }
}
