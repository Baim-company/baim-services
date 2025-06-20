using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baim.Identity.Contracts.Models.Auth;

public class AccessInfoModel
{
    public string AccessToken { get; set; }
    public string RefreshToken { get; set; }
    public DateTime AccessTokenExpireTime { get; set; }

    public AccessInfoModel() { }

    public AccessInfoModel(string accessToken, string refreshToken, DateTime accessTokenExpireTime)
    {
        AccessToken = accessToken;
        RefreshToken = refreshToken;
        AccessTokenExpireTime = accessTokenExpireTime;
    }
}
