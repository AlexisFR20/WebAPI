﻿namespace WebAPI.DTOS
{
    public class UpdateUserDTO
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string PasswordHash { get; set; }
        public TypeUser UserType { get; set; } = TypeUser.Basic;
        public bool IsDeleted { get; set; } = false;
        public DateTime CreatedAt { get; set; }
        public DateTime UpdateAt { get; set; }
    }
}
