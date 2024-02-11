using _1Projects.Shared;
using Microsoft.EntityFrameworkCore;
using System.Net.NetworkInformation;
using System.Text;
using System.Security.Cryptography;

namespace _1Projects.Context
{
    public class ProfilesDataService
    {

        private readonly DBContext _dbContext;

        public ProfilesDataService(DBContext DBContext)
        {
            _dbContext = DBContext;
        }

        public async Task<List<Shared.ProfileData>> GetAllAccounts()
        {
            return await _dbContext.profileDatas.ToListAsync();
        }

        public async Task<bool> AddNewAccount(Shared.ProfileData profile)
        {
            profile.Password = PassHash(profile.Password);
            await _dbContext.profileDatas.AddAsync(profile);
            await _dbContext.SaveChangesAsync();
            return true;
        }

        public Shared.ProfileData GetUserByEmail(string email)
        {
            return _dbContext.profileDatas.FirstOrDefault(u => u.Email == email);
        }

        public bool PasswordValidation(ProfileData user, string password)
        {
            password = PassHash(password);
            return user.Password == password;
        }

        public string PassHash(string password)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(password));

                StringBuilder Strbuilder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    Strbuilder.Append(bytes[i].ToString("x2"));
                }
                return Strbuilder.ToString();
            }
        }
    }
}
