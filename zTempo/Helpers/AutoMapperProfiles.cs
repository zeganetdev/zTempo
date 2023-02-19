using AutoMapper;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using zTempo.CrossCutting.Agents.JiraProxy.Entity;
using zTempo.CrossCutting.Agents.TempoProxy.Entity;
using zTempo.Models;

namespace zTempo.Helpers
{
    public class AutoMapperProfiles: Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<Project, JiraProject>().ReverseMap();
            CreateMap<Issue, JiraIssue>().ReverseMap();
            CreateMap<Field, JiraField>().ReverseMap();

            CreateMap<Worklog, TempoWorklog>().ReverseMap();
            CreateMap<WorklogAttribute, TempoAttribute>().ReverseMap();
        }
    }
}
