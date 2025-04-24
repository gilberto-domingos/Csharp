export interface AutorModel {
    id: string;
    nome: string;
    dataNascimento: string;
  }
  
  
  export interface AutorType {
    idAutor: number;
    nome: string;
    sobrenome: string;
  }

  
  export interface AutorCriarDto {
    nome: string;
    dataNascimento: string;
  }
  
  
  
  export interface AutorEditarDto extends AutorCriarDto {
    id: string;
  }
  