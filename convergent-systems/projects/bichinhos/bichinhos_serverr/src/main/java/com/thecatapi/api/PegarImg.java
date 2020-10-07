package com.thecatapi.api;

import java.net.HttpURLConnection;
import java.net.URL;
import java.util.Scanner;
import org.json.simple.JSONArray;
import org.json.simple.JSONObject;
import org.json.simple.parser.JSONParser;

/**
 * Classe para recuperar url da api thecatapi.com
 */
public class PegarImg {

	public static String getImgPorUrl() {
		String inline = "";
		String urlg = "";
		{

			try {

				URL url = new URL("https://api.thecatapi.com/v1/images/search");
				HttpURLConnection conn = (HttpURLConnection) url.openConnection();
				conn.setRequestMethod("GET");
				conn.connect();
				int responsecode = conn.getResponseCode();
				// System.out.println("Response code is: " + responsecode);

				// Iterating condition to if response code is not 200 then throw a runtime
				// exception
				// else continue the actual process of getting the JSON data
				if (responsecode != 200)
					throw new RuntimeException("HttpResponseCode: " + responsecode);
				else {
					// Scanner functionality will read the JSON data from the stream
					Scanner sc = new Scanner(url.openStream());
					while (sc.hasNext()) {
						inline += sc.nextLine();
					}
					// System.out.println("\nJSON Response in String format");
					// System.out.println(inline);
					// Close the stream when reading the data has been finished
					sc.close();
				}

				// JSONParser reads the data from string object and break each data into key
				// value pairs
				JSONParser parse = new JSONParser();
				// Type caste the parsed json data in json object
				JSONArray jsonarr_1 = (JSONArray) parse.parse(inline);

				// Get data for Results array

				for (int i = 0; i < jsonarr_1.size(); i++) {
					// Store the JSON objects in an array
					// Get the index of the JSON object and print the values as per the index
					JSONObject jsonobj_1 = (JSONObject) jsonarr_1.get(i);
					// System.out.println(jsonobj_1.get("url"));
					urlg = (String) jsonobj_1.get("url");
					// Disconnect the HttpURLConnection stream
					conn.disconnect();
				}

			} catch (Exception e) {
				e.printStackTrace();
			}
		}
		return urlg;
	}
}
