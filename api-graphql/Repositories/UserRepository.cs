using DevInCar.GraphQL.Context;
using DevInCar.GraphQL.Models;
using Microsoft.EntityFrameworkCore;

namespace DevInCar.GraphQL.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly IDbContextFactory<DevContext> _context;

        public UserRepository(IDbContextFactory<DevContext> context)
        {
            _context = context;
        }

        public IEnumerable<Usuario> GetUsers()
        {
            using (var context = _context.CreateDbContext())
            {
                return context.Usuarios.ToList();
            }
        }
        public Usuario GetUser(int id)
        {
            using (var context = _context.CreateDbContext())
            {
                return context.Usuarios.Single(u => u.Id == id);
            }
        }

        public Usuario AuthUser(LoginInput login)
        {
            using (var context = _context.CreateDbContext())
            {
                var usuarios = context.Usuarios
                    .Where(x => x.UserName.ToLower() == login.UserName.ToLower() && x.Password == login.Password)
                    .FirstOrDefault();
                return usuarios;
            }
        }
    }
}
