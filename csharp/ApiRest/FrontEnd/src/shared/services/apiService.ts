import axios from 'axios';

const api = axios.create({
  baseURL: 'http://localhost:5000/api', 
});

export const apiService = {
  getAutores: async () => {
    const response = await api.get('/autor/ListarAutores');
    return response.data;
  },

  createAutor: async (data: { nome: string; sobrenome: string }) => {
    const response = await api.post('/autor/CriarAutor', data);
    return response.data;
  },

  updateAutor: async (id: number, data: { nome: string; sobrenome: string }) => {
    const response = await api.put('/autor/EditarAutor', { id, ...data });
    return response.data;
  },

  deleteAutor: async (id: number) => {
    const response = await api.delete(`/autor/ExcluirAutor?idAutor=${id}`);
    return response.data;
  },
};
