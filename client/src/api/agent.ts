import axios, { AxiosResponse } from "axios";

axios.defaults.baseURL = "https://localhost:7285/api/";

const responseBody = (response: AxiosResponse) => response.data;

const requests = {
  get: (url: string) => axios.get(url).then(responseBody),
  post: (url: string, body: {}) => axios.post(url, body).then(responseBody),
  put: (url: string, body: {}) => axios.put(url, body).then(responseBody),
  delete: (url: string) => axios.delete(url).then(responseBody),
};

const ClassRoomDetails = {
  list: () => requests.get("ClassRoom"),
  details: (id: number) => requests.get(`ClassRoom/${id}`),
};

const Resources = {
  details: (id: number) => requests.get(`Resource/${id}`),
};

const Booking = {
  addBooking: (booking: any) => requests.post(`Booking`, {}),
  removeBoooking: (id: number) => requests.delete(`Booking?${id}`),
};

const agent = {
  ClassRoomDetails,
  Resources,
  Booking,
};

export default agent;
