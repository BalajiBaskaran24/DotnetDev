import axios, { AxiosResponse, AxiosError } from "axios";
import { CONFIGURE_URL } from "@/Constants";
import { Console } from "console";
// Define callback types for success and error handling
type CallbackFunction = (response: AxiosResponse<any>) => void;
type ErrorFunction = (error: AxiosError) => void;

const api = {
  getAPI(url: string, response: CallbackFunction, error: ErrorFunction): void {
    this._call("get", CONFIGURE_URL + url, null, response, error);
  },

  putAPI(
    url: string,
    parameter: any,
    response: CallbackFunction,
    error: ErrorFunction
  ): void {
    parameter = JSON.stringify(parameter);
    this._call("put", CONFIGURE_URL + url, parameter, response, error);
    console.log(
      "put api is called -" + CONFIGURE_URL + url + "paramter " + parameter
    );
  },

  _call(
    method: string,
    path: string,
    parameters: any,
    callback: CallbackFunction,
    onError: ErrorFunction
  ): void {
    axios({
      method: method,
      url: path,
      data: parameters,
      headers: {
        "Content-Type": "application/json", // Set Content-Type to application/json
      },
    })
      .then(function (response: AxiosResponse<any>) {
        callback(response);
      })
      .catch(function (error: AxiosError) {
        console.log(error);
        if (onError) onError(error);
      });
  },
};

export default api;
