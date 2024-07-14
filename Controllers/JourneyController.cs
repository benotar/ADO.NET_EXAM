﻿using exam2.Entities;
using exam2.SQRS.Commands;
using exam2.SQRS.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace exam2.Controllers;

[ApiController]
[Route("api/[controller]/[action]")]
public class JourneyController : Controller
{
    private readonly ISender _sender;

    public JourneyController(ISender sender) => _sender = sender;

    [HttpGet("{cityName}")]
    public async Task<ActionResult<List<Journey>>> GetJourneysArrivingTo(string cityName)
    {
        try
        {
            var journeys = await _sender.Send(new GetJourneysArrivingToQuery(cityName));

            if (!journeys.Any())
            {
                return NotFound($"Journeys to \'{cityName}\' is not found in the database!");
            }
            
            return Ok(journeys.ToList());
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }
    
    [HttpPost]
    public async Task<ActionResult<Journey>> AddJourney(CreateJourneyCommand command)
    {
        try
        {
            var journey = await _sender.Send(command);

            var commandTicket = new CreateTicketsCommand(journey.Id);

            var isTicketAdded = await _sender.Send(commandTicket);

            if (!isTicketAdded)
            {
                return BadRequest("Failed to generate tickets for the journey!");
            }
            
            return Ok(journey);
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }
    
}