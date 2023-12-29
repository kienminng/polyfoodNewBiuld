// using PolyFood.Entity.Entity;
// using PolyFood.Repository.Context;
// using PolyFood.Repository.Repository.IRepo;
//
// namespace PolyFood.Repository.Repository.Impl;
//
// public class CartItemRepo : ICartItemRepo
// {
//     private readonly AppDbContext _context;
//
//     public CartItemRepo(AppDbContext context)
//     {
//         _context = context;
//     }
//
//     public CartItem? GetById(int id)
//     {
//         var result = _context.CartItems.Find(id);
//         return result;
//     }
//
//     public IEnumerable<CartItem> GetAll()
//     {
//         var result = _context.CartItems.AsEnumerable();
//         return result;
//     }
//
//     public void Add(CartItem entity)
//     {
//         _context.CartItems.Add(entity);
//         _context.SaveChanges();
//     }
//
//     public void Update(CartItem entity)
//     {
//         _context.CartItems.Update(entity);
//         _context.SaveChanges();
//     }
//
//     public void Delete(CartItem entity)
//     {
//         _context.CartItems.Remove(entity);
//         _context.SaveChanges();
//     }
// }