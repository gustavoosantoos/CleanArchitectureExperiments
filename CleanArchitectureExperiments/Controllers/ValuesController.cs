﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CleanArchitectureExperiments.Application.Clients;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CleanArchitectureExperiments.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ValuesController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost("id")]
        public async Task<ActionResult> Get(int id)
        {
            await _mediator.Send(new SaveNewClientCommand()
            {
                Id = id
            });

            return Ok();
        }
    }
}
