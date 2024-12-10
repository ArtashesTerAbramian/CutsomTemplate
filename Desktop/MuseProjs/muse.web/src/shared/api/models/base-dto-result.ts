/* tslint:disable */
import { ResultStatus } from './result-status';
import { ValidationError } from './validation-error';
import { BaseDto } from './base-dto';
export interface BaseDtoResult {
  correlationId?: string;
  errors?: Array<string>;
  isSuccess?: boolean;
  status?: ResultStatus;
  successMessage?: string;
  validationErrors?: Array<ValidationError>;
  value?: BaseDto;
}
