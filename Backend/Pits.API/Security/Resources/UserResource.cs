﻿namespace Mecanillama.API.Security.Resources;

public class UserResource
{
    public int Id { get; set; }
    public string Name { get; set; } = null!;
    public string Email { get; set; } = null!;
    public string Role { get; set; } = null!;
}