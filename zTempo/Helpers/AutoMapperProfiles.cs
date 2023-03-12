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
using User = zTempo.Models.User;

namespace zTempo.Helpers
{
    public class AutoMapperProfiles: Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<Project, JiraProject>().ReverseMap();
            CreateMap<Issue, JiraIssue>().ReverseMap();
            CreateMap<Field, JiraField>().ReverseMap();
            CreateMap<User, JiraUser>().ReverseMap();

            CreateMap<Worklog, TempoWorklog>().ReverseMap();
            CreateMap<Worklogs, TempoWorklogs>().ReverseMap();
            CreateMap<Issue, TempoIssue>().ReverseMap();
            CreateMap<WorklogAttribute, TempoAttribute>().ReverseMap();
        }
    }
}
