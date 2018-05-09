using RestSharp;

namespace Utilities.Random
{
	public class Random
	{
		private const string ApiUrl = "https://api.random.org";

		public void Foo()
		{
			var client = new RestClient(ApiUrl);

			var request = new RestRequest("json-rpc/1/invoke", Method.POST);
			
			request.AddJsonBody(new
			{
				jsonrpc = "2.0",
				method = "generateIntegers",
				@params = new {
					apiKey = "c5f0253c-aca4-4869-9b14-8c982f550d41",
					n = 6,
					min = 1,
					max = 6
				},
				id = 42
			});

			var response = client.Execute(request);

		}
	}
}
