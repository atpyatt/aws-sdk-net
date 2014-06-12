/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.Redshift.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
namespace Amazon.Redshift.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for PendingModifiedValues Object
    /// </summary>  
    public class PendingModifiedValuesUnmarshaller : IUnmarshaller<PendingModifiedValues, XmlUnmarshallerContext>, IUnmarshaller<PendingModifiedValues, JsonUnmarshallerContext>
    {
        public PendingModifiedValues Unmarshall(XmlUnmarshallerContext context)
        {
            PendingModifiedValues unmarshalledObject = new PendingModifiedValues();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            
            if (context.IsStartOfDocument) 
               targetDepth += 2;
            
            while (context.Read())
            {
                if (context.IsStartElement || context.IsAttribute)
                {
                    if (context.TestExpression("AutomatedSnapshotRetentionPeriod", targetDepth))
                    {
                        var unmarshaller = IntUnmarshaller.GetInstance();
                        unmarshalledObject.AutomatedSnapshotRetentionPeriod = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("ClusterIdentifier", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.GetInstance();
                        unmarshalledObject.ClusterIdentifier = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("ClusterType", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.GetInstance();
                        unmarshalledObject.ClusterType = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("ClusterVersion", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.GetInstance();
                        unmarshalledObject.ClusterVersion = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("MasterUserPassword", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.GetInstance();
                        unmarshalledObject.MasterUserPassword = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("NodeType", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.GetInstance();
                        unmarshalledObject.NodeType = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("NumberOfNodes", targetDepth))
                    {
                        var unmarshaller = IntUnmarshaller.GetInstance();
                        unmarshalledObject.NumberOfNodes = unmarshaller.Unmarshall(context);
                        continue;
                    }
                }
                else if (context.IsEndElement && context.CurrentDepth < originalDepth)
                {
                    return unmarshalledObject;
                }
            }

            return unmarshalledObject;
        }

        public PendingModifiedValues Unmarshall(JsonUnmarshallerContext context)
        {
            return null;
        }


        private static PendingModifiedValuesUnmarshaller instance;
        public static PendingModifiedValuesUnmarshaller GetInstance()
        {
            if (instance == null)
            {
                instance = new PendingModifiedValuesUnmarshaller();
            }
            return instance;
        }

    }
}