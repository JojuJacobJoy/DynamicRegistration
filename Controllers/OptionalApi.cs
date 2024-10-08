/*
 * Dynamic Client Registration API
 *
 * This specification defines the APIs for a TPP to submit a Software Statement Assertion to an ASPSP for the purpose of creating OAuth clients that are registered with ASPSP. 
 *
 * OpenAPI spec version: v3.1-RC1
 * Contact: ServiceDesk@openbanking.org.uk
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.WebUtilities;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Primitives;
using Swashbuckle.AspNetCore.SwaggerGen;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using IO.Swagger.Attributes;
using IO.Swagger.Models;

namespace IO.Swagger.Controllers
{ 
    /// <summary>
    /// 
    /// </summary>
    public class OptionalApiController : Controller
    { 
        /// <summary>
        /// Delete a client by way of Client ID
        /// </summary>
        
        /// <param name="clientId">The client ID</param>
        /// <param name="authorization">An Authorisation Token as per https://tools.ietf.org/html/rfc6750</param>
        /// <response code="204">Client deleted</response>
        /// <response code="401">Request failed due to unknown or invalid Client or invalid access token</response>
        /// <response code="403">The client does not have permission to read, update or delete the Client</response>
        /// <response code="405">The client does not have permission to read, update or delete the Client</response>
        [HttpDelete]
        [Route("/register/{ClientId}")]
        [ValidateModelState]
        [SwaggerOperation("RegisterClientIdDelete")]
        public virtual IActionResult RegisterClientIdDelete([FromRoute][Required]string clientId, [FromHeader][Required()]string authorization)
        { 
            //TODO: Uncomment the next line to return response 204 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(204);

            //TODO: Uncomment the next line to return response 401 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(401);

            //TODO: Uncomment the next line to return response 403 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(403);

            //TODO: Uncomment the next line to return response 405 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(405);


            throw new NotImplementedException();
        }

        /// <summary>
        /// Get a client by way of Client ID
        /// </summary>
        
        /// <param name="clientId">The client ID</param>
        /// <param name="authorization">An Authorisation Token as per https://tools.ietf.org/html/rfc6750</param>
        /// <response code="200">Client registration</response>
        /// <response code="401">Request failed due to unknown or invalid Client or invalid access token</response>
        /// <response code="403">The client does not have permission to read, update or delete the Client</response>
        [HttpGet]
        [Route("/register/{ClientId}")]
        [ValidateModelState]
        [SwaggerOperation("RegisterClientIdGet")]
        [SwaggerResponse(statusCode: 200, type: typeof(InlineResponse201), description: "Client registration")]
        public virtual IActionResult RegisterClientIdGet([FromRoute][Required]string clientId, [FromHeader][Required()]string authorization)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(InlineResponse201));

            //TODO: Uncomment the next line to return response 401 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(401);

            //TODO: Uncomment the next line to return response 403 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(403);

            string exampleJson = null;
            exampleJson = "{\n  \"OBRegistrationProperties1\" : {\n    \"tls_client_auth_dn\" : \"tls_client_auth_dn\",\n    \"token_endpoint_auth_signing_alg\" : null,\n    \"grant_types\" : [ \"client_credentials\", \"client_credentials\" ],\n    \"application_type\" : \"web\",\n    \"redirect_uris\" : [ \"http://example.com/aeiou\", \"http://example.com/aeiou\" ],\n    \"client_id\" : \"client_id\",\n    \"token_endpoint_auth_method\" : \"private_key_jwt\",\n    \"software_id\" : \"software_id\",\n    \"software_statement\" : \"software_statement\",\n    \"client_secret_expires_at\" : 0,\n    \"scope\" : [ \"scope\", \"scope\" ],\n    \"client_secret\" : \"client_secret\",\n    \"client_id_issued_at\" : 0,\n    \"request_object_signing_alg\" : null,\n    \"response_types\" : [ \"code\", \"code\" ],\n    \"id_token_signed_response_alg\" : { }\n  }\n}";
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<InlineResponse201>(exampleJson)
            : default(InlineResponse201);
            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// Update a client by way of Client ID
        /// </summary>
        
        /// <param name="clientId">The client ID</param>
        /// <param name="authorization">An Authorisation Token as per https://tools.ietf.org/html/rfc6750</param>
        /// <param name="requestBody">A request to register a Software Statement Assertion with an ASPSP</param>
        /// <response code="200">Client registration</response>
        /// <response code="400">Request failed due to client error</response>
        /// <response code="401">Request failed due to unknown or invalid Client or invalid access token</response>
        /// <response code="403">The client does not have permission to read, update or delete the Client</response>
        [HttpPut]
        [Route("/register/{ClientId}")]
        [ValidateModelState]
        [SwaggerOperation("RegisterClientIdPut")]
        [SwaggerResponse(statusCode: 200, type: typeof(InlineResponse201), description: "Client registration")]
        [SwaggerResponse(statusCode: 400, type: typeof(RegistrationError), description: "Request failed due to client error")]
        public virtual IActionResult RegisterClientIdPut([FromRoute][Required]string clientId, [FromHeader][Required()]string authorization, [FromBody]string requestBody)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(InlineResponse201));

            //TODO: Uncomment the next line to return response 400 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(400, default(RegistrationError));

            //TODO: Uncomment the next line to return response 401 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(401);

            //TODO: Uncomment the next line to return response 403 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(403);

            string exampleJson = null;
            exampleJson = "{\n  \"OBRegistrationProperties1\" : {\n    \"tls_client_auth_dn\" : \"tls_client_auth_dn\",\n    \"token_endpoint_auth_signing_alg\" : null,\n    \"grant_types\" : [ \"client_credentials\", \"client_credentials\" ],\n    \"application_type\" : \"web\",\n    \"redirect_uris\" : [ \"http://example.com/aeiou\", \"http://example.com/aeiou\" ],\n    \"client_id\" : \"client_id\",\n    \"token_endpoint_auth_method\" : \"private_key_jwt\",\n    \"software_id\" : \"software_id\",\n    \"software_statement\" : \"software_statement\",\n    \"client_secret_expires_at\" : 0,\n    \"scope\" : [ \"scope\", \"scope\" ],\n    \"client_secret\" : \"client_secret\",\n    \"client_id_issued_at\" : 0,\n    \"request_object_signing_alg\" : null,\n    \"response_types\" : [ \"code\", \"code\" ],\n    \"id_token_signed_response_alg\" : { }\n  }\n}";
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<InlineResponse201>(exampleJson)
            : default(InlineResponse201);
            //TODO: Change the data returned
            return new ObjectResult(example);
        }
    }
}
