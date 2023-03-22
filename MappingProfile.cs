using AutoMapper;
using E_Comm.Models;
using E_Comm.Models.DataTranferObject;

namespace E_Comm
{
    public class MappingProfile : Profile
    {
        public MappingProfile() {

            CreateMap<Users, UserDTO>().ForMember(U => U.FullName, X => X.MapFrom(
                    X => string.Join(' ', X.FirstName, X.LastName)));

            CreateMap<UserRegistrationDTO , Users>();
            CreateMap<Product, ProductDTO>();
            CreateMap<ProductCreationDTO, Product>();
            CreateMap<ProductUpdateDTO, Product>();
            CreateMap<Users, UserUpdateDTO>();
            CreateMap<Orders, OrderDTO>().ReverseMap();
            CreateMap<CartItemCreationDTO, CartItem>().ReverseMap();
            CreateMap<OrderForCreationDTO, Orders>().ReverseMap();
            CreateMap<CartItem, CartDTO>().ReverseMap();
            CreateMap<OrderForUpdateDTO, Orders>().ReverseMap();


        }
    }
}
