﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ADSBackend.Models.MemberViewModels
{
    public class MemberViewModel
    {
        [Key]
        public int MemberId { get; set; }

        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        public string FullName { get; set; }

        public string Gender { get; set; }

        public string Address { get; set; }

        public string City { get; set; }

        public string State { get; set; } = "PA";

        [Display(Name = "Zip Code")]
        public string ZipCode { get; set; }

        public int Grade { get; set; }

        [Display(Name = "Recruited By")]
        public string RecruitedBy { get; set; }

        public string Email { get; set; }

        public string Phone { get; set; }

        [Display(Name = "Profile Picture")]
        public string profileImageSource { get; set; }

        [Display(Name = "Bio")]
        public string Description { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        public List<ClubMember> ClubMembers { get; set; }

        public List<MeetingAttendees> MeetingAttendees { get; set; } //attendees

        public List<int> ClubIds { get; set; }

        public List<int> MeetingIds { get; set; }

        public MemberViewModel()
        {

        }

        public MemberViewModel(Member member)
        {
            this.MemberId = member.MemberId;
            this.FirstName = member.FirstName;
            this.LastName = member.LastName;
            this.Gender = member.Gender;
            this.Address = member.Address;
            this.City = member.City;
            this.State = member.State;
            this.ZipCode = member.ZipCode;
            this.Grade = member.Grade;
            this.RecruitedBy = member.RecruitedBy;
            this.Email = member.Email;
            this.Password = member.Password;
            this.Phone = member.Phone;
            this.profileImageSource = member.profileImageSource;
            this.Description = member.Description;
            this.ClubMembers = member.ClubMembers;
            this.MeetingAttendees = member.MeetingAttendees;
            this.ClubIds = member.ClubMembers?.Select(cm => cm.ClubId).ToList();
            this.MeetingIds = member.MeetingAttendees?.Select(ma => ma.MeetingId).ToList();
        }
    }
}
