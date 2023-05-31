namespace boilerplate_aspnet.Common.DTOs;

public class CreateUserDTO
{
    public string name { get; set; }
    public string email { get; set; }
    public string password { get; set; }
    public DateTime? createdAt { get; set; }
    public DateTime? updatedAt { get; set; }
    public Guid roleId { get; set; }
}

public class UpdateUserDTO
{
    public string? name { get; set; }
    public string? email { get; set; }
    public string? password { get; set; }
    public DateTime? createdAt { get; set; }
    public DateTime? updatedAt { get; set; }
    public Guid? roleId { get; set; }
}