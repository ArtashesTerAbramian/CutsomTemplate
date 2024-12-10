/* tslint:disable */
import { ResultStatus } from './result-status';
import { ValidationError } from './validation-error';
export interface Result {
  correlationId?: string;
  errors?: Array<string>;
  isSuccess?: boolean;
  status?: ResultStatus;
  successMessage?: string;
  validationErrors?: Array<ValidationError>;
  value?: Result;
}
