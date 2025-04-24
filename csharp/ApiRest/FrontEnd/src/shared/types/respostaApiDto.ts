export interface RespostaApiDto<T> {
    sucesso: boolean;
    dados: T;
    mensagem: string;
  }
  