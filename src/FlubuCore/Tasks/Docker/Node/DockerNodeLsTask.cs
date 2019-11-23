
//-----------------------------------------------------------------------
// <auto-generated />
//-----------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Attributes;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Tasks.Docker.Node
{
     public partial class DockerNodeLsTask : ExternalProcessTaskBase<int, DockerNodeLsTask>
     {
        
        
        public DockerNodeLsTask()
        {
            ExecutablePath = "docker";
            WithArguments("node ls");

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// Filter output based on conditions provided
        /// </summary>
        [ArgKey("--filter")]
        public DockerNodeLsTask Filter(string filter)
        {
            WithArgumentsKeyFromAttribute(filter.ToString());
            return this;
        }

        /// <summary>
        /// Pretty-print nodes using a Go template
        /// </summary>
        [ArgKey("--format")]
        public DockerNodeLsTask Format(string format)
        {
            WithArgumentsKeyFromAttribute(format.ToString());
            return this;
        }

        /// <summary>
        /// Only display IDs
        /// </summary>
        [ArgKey("--quiet")]
        public DockerNodeLsTask Quiet()
        {
            WithArgumentsKeyFromAttribute();
            return this;
        }
        protected override int DoExecute(ITaskContextInternal context)
        {
            
            return base.DoExecute(context);
        }

     }
}