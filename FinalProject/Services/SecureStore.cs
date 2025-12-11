using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Services
{
    public class SecureStore : ISecureStorage
    {
        public async Task<string?> GetAsync(string key)
        {
            return await SecureStorage.GetAsync(key);
        }

        public async Task SetAsync(string key, string value)
        {
            await SecureStorage.SetAsync(key, value);
        }

        public bool Remove(string key)
        {
            SecureStorage.Remove(key);
            return true;
        }

        public void RemoveAll()
        {
            SecureStorage.RemoveAll();
        }

        
    }
}
