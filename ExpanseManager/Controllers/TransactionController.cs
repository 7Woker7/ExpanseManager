﻿using AutoMapper;
using ExpanseManager.DTO;
using ExpanseManager.Repositories;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Transactions;

namespace ExpanseManager.Controllers
{
    [Route("api/transaction")]
    public class TransactionController : ControllerBase
    {
        
        private readonly ITransactionRepository _repository;
        private readonly IMapper _mapper;

        public TransactionController(ITransactionRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        [HttpGet]
        public ActionResult<IEnumerable<TransactionReadDto>> GetAll()
        {
            var transactionItems = _repository.GetAll();
            return Ok(_mapper.Map<IEnumerable<TransactionReadDto>>(transactionItems));
        }

        [HttpGet("{id}")]
        public ActionResult<TransactionReadDto> GetById(int id)
        {
            var transactionItem = _repository.GetById(id);
            if (transactionItem != null)
            {
                return Ok(_mapper.Map<TransactionReadDto>(transactionItem));
            }
            return NotFound();
        }

        [HttpPost]
        public ActionResult<TransactionReadDto> Create([FromBody] TransactionCreateDto transactionCreateDto)
        {
            var transactionModel = _mapper.Map<Transaction>(transactionCreateDto);
            //   _repository.Create(transactionModel);

            var transactionReadDto = _mapper.Map<TransactionReadDto>(transactionModel);

            return Ok(transactionReadDto);
        }
            
        [HttpDelete]
        public ActionResult Delete(int id)
        {
            var transactionDeleteModel = _repository.GetById(id);
            if (transactionDeleteModel == null)
            {
                return NotFound();
            }
            _repository.Delete(transactionDeleteModel);

            return NoContent();
        }
        
    }
}

