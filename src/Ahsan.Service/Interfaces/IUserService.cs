﻿using Ahsan.Domain.Entities;
using Ahsan.Service.DTOs.Users;
using System.Linq.Expressions;

namespace Ahsan.Service.Interfaces;

public interface IUserService
{
    ValueTask<UserForResultDto> CreateAsync(UserForCreationDto dto);
    ValueTask<UserForResultDto> UpdateAsync(UserForUpdateDto dto);
    ValueTask<UserForResultDto> ChangePasswordAsync(UserForChangePassword dto);
    ValueTask<UserForResultDto> GetByIdAsync(long id);
    ValueTask<IEnumerable<UserForResultDto>> GetAllAsync(
        Expression<Func<User, bool>> expression = null, string search = null);
    ValueTask<bool> DeleteAsync(long id);
    ValueTask<UserImageForResultDto> ImageUploadAsync(UserImageForCreationDto dto);
    ValueTask<UserImageForResultDto> GetUserImageAsync(long userId);
    ValueTask<bool> DeleteUserImageAsync(long userId);
    ValueTask<UserForResultDto> CheckUserAsync(string username, string password = null);
    ValueTask<UserForResultDto> UserVerify(string code);
}
