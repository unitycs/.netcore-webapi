﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace General.EntityFrameworkCore.User
{
    /// <summary>
    /// 用户表
    /// </summary>
    [Table("User")]
    public class User
    {
        /// <summary>
        /// 主键
        /// </summary>
        [Key]
        public int No { get; set; }
        /// <summary>
        /// 照片id
        /// </summary>
        public int?  PhotoNo { get; set; }
        /// <summary>
        /// 账号
        /// </summary>
        public string  UserAccount { get; set; }
        /// <summary>
        /// 密码
        /// </summary>
        public string  Password { get; set; }
        /// <summary>
        /// 工作电话
        /// </summary>
        public string  JobNumber { get; set; }
        /// <summary>
        /// 名称
        /// </summary>
        public string  Name { get; set; }
        /// <summary>
        /// gender
        /// </summary>
        public bool Gender { get; set; }
        /// <summary>
        /// 手机号
        /// </summary>
        public string  Mobile { get; set; }
        /// <summary>
        /// 邮箱
        /// </summary>
        public string  Email { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string  Post { get; set; }
        public string  DepartmentId { get; set; }
        public string  EasemobId { get; set; }
        public string  EasemobPassword { get; set; }
    }
}