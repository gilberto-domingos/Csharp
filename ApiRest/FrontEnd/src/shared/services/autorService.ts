import axios from 'axios';
import { AutorModel, AutorCriarDto, AutorEditarDto } from '../types/autorTypes';
import { RespostaApiDto } from '../types/respostaApiDto';

const API_URL = 'http://localhost:5199/api/Autor';

export const listarAutores = () =>
  axios.get<RespostaApiDto<AutorModel[]>>(`${API_URL}/ListarAutores`);

export const listarAutorId = (id: string) =>
  axios.get<RespostaApiDto<AutorModel>>(`${API_URL}/ListarAutorId/${id}`);

export const criarAutor = (data: AutorCriarDto) =>
  axios.post<RespostaApiDto<AutorModel[]>>(`${API_URL}/CriarAutor`, data);

export const editarAutor = (data: AutorEditarDto) =>
  axios.put<RespostaApiDto<AutorModel[]>>(`${API_URL}/EditarAutor`, data);

export const excluirAutor = (id: string) =>
  axios.delete<RespostaApiDto<AutorModel[]>>(`${API_URL}/ExcluirAutor`, { params: { idAutor: id } });
