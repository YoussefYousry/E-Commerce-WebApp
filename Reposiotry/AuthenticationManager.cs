using E_Comm.Constracts;
using E_Comm.Models;
using E_Comm.Models.DataTranferObject;
using Microsoft.AspNetCore.Identity;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace E_Comm.Reposiotry
{
    public class AuthenticationManager : IAuthenticationManager
    {
        private readonly UserManager<Users> _userManager;
        private readonly IConfiguration _configuration;

        public AuthenticationManager(UserManager<Users> userManager , IConfiguration configuration)
        {
            _userManager = userManager;
            _configuration = configuration;
            
        }
        private Users _users ;
        public async Task<bool> ValidateUser(UserAuthenticationDTO userAuthenticationDTO)
        {
            _users = await _userManager.FindByNameAsync(userAuthenticationDTO.UserName);
            return (_users != null && await _userManager.CheckPasswordAsync(_users, userAuthenticationDTO.Password));
        }

        public async Task<string> CreateToken() //collecting information from the private methods and serializing token options
        {
            var signingCredentials = GetSigningCredentials();
            var claims = await GetClaims();
            var tokenOptions = GenerateTokenOptions(signingCredentials, claims);

            return new JwtSecurityTokenHandler().WriteToken(tokenOptions);
        }

        private SigningCredentials GetSigningCredentials() //returns secret key as a byte array with the security algorithm
        {
            var key = Encoding.UTF8.GetBytes(Environment.GetEnvironmentVariable("SECRET"));
            var secret = new SymmetricSecurityKey(key);

            return new SigningCredentials(secret,SecurityAlgorithms.HmacSha256);
        }
        private async Task<List<Claim>> GetClaims() //method creates a list of claims with the user name inside and all the roles the user
        {
            var claims = new List<Claim>
            {
                new Claim(ClaimTypes.Name , _users.UserName)
            };
            var roles = await _userManager.GetRolesAsync(_users);
            foreach(var role in roles)
            {
                claims.Add(new Claim(ClaimTypes.Role, role));
            }
            return claims;
        }

        private JwtSecurityToken GenerateTokenOptions(SigningCredentials signingCredentials , List<Claim> claims)
        {
            var jwtSettings = _configuration.GetSection("JwtSettings");

            var tokenOptions = new JwtSecurityToken
                (
                   issuer: jwtSettings.GetSection("validIssuer").Value,
                   audience: jwtSettings.GetSection("validAudience").Value,
                   claims: claims,
                   expires: DateTime.Now.AddMinutes(Convert.ToDouble(jwtSettings.GetSection("expires").Value)),
                   signingCredentials: signingCredentials
                );
            return tokenOptions;
        }

    }
}
