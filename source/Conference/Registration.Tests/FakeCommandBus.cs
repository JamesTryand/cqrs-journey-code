﻿// ==============================================================================================================
// Microsoft patterns & practices
// CQRS Journey project
// ==============================================================================================================
// Copyright (c) Microsoft Corporation and contributors http://cqrsjourney.github.com/contributors/members
// Licensed under the Apache License, Version 2.0 (the "License"); you may not use this file except in compliance 
// with the License. You may obtain a copy of the License at http://www.apache.org/licenses/LICENSE-2.0
// Unless required by applicable law or agreed to in writing, software distributed under the License is 
// distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied. 
// See the License for the specific language governing permissions and limitations under the License.
// ==============================================================================================================

namespace Registration.Tests
{
    using System.Collections.Generic;
    using Common;

    public class FakeCommandBus : ICommandBus
    {
        private readonly List<ICommand> sentCommands = new List<ICommand>();

        public List<ICommand> SentCommands
        {
            get { return this.sentCommands; }
        }

        public void Send(ICommand command)
        {
            this.sentCommands.Add(command);
        }


		public void Send(IEnumerable<ICommand> commands)
		{
			this.sentCommands.AddRange(commands);
		}
	}
}
