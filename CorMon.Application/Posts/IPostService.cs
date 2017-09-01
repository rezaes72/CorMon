﻿using CorMon.Application.Posts.Dto;
using CorMon.Core.Enums;
using CorMon.Core.JsonModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CorMon.Application.Posts
{
   public interface IPostService
    {
        Task<PostInput> GetToUpdateAsync(string id);
        Task<PostOutput> GetAsync(string id);
        Task<PostJsonResult> CreateAsync(PostInput input);
        Task<PostJsonResult> UpdateAsync(PostInput input);
        IEnumerable<PostOutput> Search(int page, int recordsPerPage, string term, PublishStatus? publishStatus, SortOrder sortOrder, out int pageSize, out int TotalItemCount);
        Task<IEnumerable<PostOutput>> SearchAsync(int page, int recordsPerPage, string term, PublishStatus? publishStatus, SortOrder sortOrder);
    }
}
