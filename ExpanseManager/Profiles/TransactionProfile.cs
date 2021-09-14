using AutoMapper;
using ExpanseManager.DTO;
using System.Transactions;

namespace ExpanseManager.Profiles
{
    public class TransactionProfile : Profile
    {
        public TransactionProfile()
        {
            CreateMap<Transaction, TransactionReadDto>();
            CreateMap<TransactionCreateDto, Transaction>();
        }
    }
}
