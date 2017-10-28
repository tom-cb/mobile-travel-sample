﻿// 
// IDatabaseSeedService.cs
// 
// Author:
//     Jim Borden  <jim.borden@couchbase.com>
// 
// Copyright (c) 2017 Couchbase, Inc All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// 
// http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// 
using System.Threading.Tasks;

namespace TravelSample.Core.Services
{
    /// <summary>
    /// A service to retrieve a bundled database
    /// </summary>
    public interface IDatabaseSeedService
    {
        #region Public Methods

        /// <summary>
        /// Copies the bundled database to a directory for use
        /// </summary>
        /// <param name="directoryPath">The path to copy the database to</param>
        /// <returns>An <c>await</c>able <see cref="Task"/> representing the copy operation</returns>
        Task CopyDatabaseAsync(string directoryPath);

        #endregion
    }
}