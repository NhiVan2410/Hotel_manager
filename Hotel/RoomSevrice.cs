using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel
{
    public  class RoomSevrice
    {
        public void AddRoom(string roomType, decimal roomPrice, bool isAvailable)
        {
            using (var context = new HotelDbContext())
            {
                var room = new Room
                {
                    RoomType = roomType,
                    RoomPrice = roomPrice,
                    IsAvailable = isAvailable ? 1 : 0, // true => 1, false => 0
                    CreatedAt = DateTime.Now,  // Cập nhật CreatedAt khi thêm mới
                    UpdatedAt = DateTime.Now,  // Đồng thời cập nhật UpdatedAt
                    IsDeleted = 0        // Phòng mặc định không bị xóa
                };

                context.Rooms.InsertOnSubmit(room);
                context.SubmitChanges();
                Console.WriteLine("Room added successfully!");
            }
        }
        // Lấy danh sách tất cả các phòng (không bao gồm phòng đã xóa)
        public IQueryable<Room> GetAllRooms()
        {
            using (var context = new HotelDbContext())
            {
                return context.Rooms.Where(r => r.IsDeleted == 0); // Lọc các phòng chưa bị xóa
            }
        }
        // Cập nhật thông tin phòng
        public void UpdateRoom(int roomId, string roomType, decimal roomPrice, bool isAvailable)
        {
            using (var context = new HotelDbContext())
            {
                var room = context.Rooms.FirstOrDefault(r => r.RoomID == roomId);
                if (room != null)
                {
                    room.RoomType = roomType;
                    room.RoomPrice = roomPrice;
                    room.IsAvailable = isAvailable ? 1 : 0;
                    room.UpdatedAt = DateTime.Now; // Cập nhật UpdatedAt khi chỉnh sửa

                    context.SubmitChanges();
                    Console.WriteLine("Room updated successfully!");
                }
                else
                {
                    Console.WriteLine("Room not found.");
                }
            }
        }

        // Xóa phòng (xóa mềm)
        public void DeleteRoom(int roomId)
        {
            using (var context = new HotelDbContext())
            {
                var room = context.Rooms.FirstOrDefault(r => r.RoomID == roomId);
                if (room != null)
                {
                    room.IsDeleted = 1;          // Đánh dấu phòng đã bị xóa
                    room.UpdatedAt = DateTime.Now; // Cập nhật thời gian bị xóa

                    context.SubmitChanges();
                    Console.WriteLine("Room deleted successfully!");
                }
                else
                {
                    Console.WriteLine("Room not found.");
                }
            }
        }

        // Tìm kiếm phòng theo trạng thái (còn trống hoặc không)
        public IQueryable<Room> GetAvailableRooms(bool isAvailable)
        {
            using (var context = new HotelDbContext())
            {
                return context.Rooms.Where(r => r.IsAvailable == (isAvailable ? 1 : 0) && r.IsDeleted == 0);
            }
        }

    }
}
