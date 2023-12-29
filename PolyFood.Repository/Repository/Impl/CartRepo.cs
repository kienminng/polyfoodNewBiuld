// using Microsoft.EntityFrameworkCore;
// using PolyFood.Entity.Entity;
// using PolyFood.Repository.Context;
// using PolyFood.Repository.Repository.IRepo;
//
// namespace PolyFood.Repository.Repository.Impl;
//
// public class CartRepo : ICartRepo
// {
//     private readonly AppDbContext _context;
//
//     public CartRepo(AppDbContext context)
//     {
//         _context = context;
//     }
//
//     public Cart? GetById(int id)
//     {
//         var result = _context.Carts
//             .Include(x => x.Items)
//             .FirstOrDefault(x => x.Cart_Id == id);
//         return result;
//     }
//
//     public IEnumerable<Cart> GetAll()
//     {
//         var result = _context.Carts.AsEnumerable();
//         return result;
//     }
//
//     public void Add(Cart entity)
//     {
//         var result = _context.Carts.Add(entity);
//         _context.SaveChanges();
//     }
//
//     public void Update(Cart entity)
//     {
//         _context.Carts.Update(entity);
//         _context.SaveChanges();
//     }
//
//     public void Delete(Cart entity)
//     {
//         _context.Carts.Remove(entity);
//         _context.SaveChanges();
//     }
// }