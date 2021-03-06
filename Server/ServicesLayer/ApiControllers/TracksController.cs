﻿using System.Collections.Generic;
using System.Web.Http;
using BusinessLogicLayer;
using DataLayer.Model;

namespace ServicesLayer.ApiControllers
{
    public class TracksController : ApiController
    {
        private IConferenceManager conferenceManager;

        public TracksController(IConferenceManager manager)
        {
            conferenceManager = manager;
        }

        [HttpGet]
        [ActionName("list")]
        public IList<Track> GetTrackList()
        {
            return conferenceManager.GetTrackList();
        }

        [HttpGet]
        [ActionName("list")]
        public Track GetTrackById(int id)
        {
            return conferenceManager.GetTrackById(id);
        }

        [HttpGet]
        [ActionName("search")]
        public Track SearchTrackByName(string track)
        {
            return conferenceManager.SearchTrackByName(track);
        }

        [HttpGet]
        [ActionName("type")]
        public Track SearchTrackTypeByName(string track)
        {
            return conferenceManager.SearchTrackTypeByName(track);
        }

        [HttpPost]
        [ActionName("list")]
        public Track AddTrack(Track track)
        {
            return conferenceManager.AddTrack(track);
        }

        [HttpPut]
        [ActionName("list")]
        public void UpdateTrack(Track track)
        {
            conferenceManager.UpdateTrack(track);
        }

        [HttpDelete]
        [ActionName("list")]
        public void DeleteTrack(int id)
        {
            conferenceManager.DeleteTrack(id);
        }
    }
}