/**
 * server_dotnet
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: v1
 * 
 *
 * NOTE: This class is auto generated by OpenAPI Generator (https://openapi-generator.tech).
 * https://openapi-generator.tech
 * Do not edit the class manually.
 */
import { Sport } from './sport';
import { Address } from './address';


export interface Person { 
    name: string;
    address: Address;
    favoriteQuote?: string | null;
    interest?: Sport;
    dateOfBirth?: string;
}

