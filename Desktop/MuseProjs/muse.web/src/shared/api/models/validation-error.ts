/* tslint:disable */
import { ValidationSeverity } from './validation-severity';
export interface ValidationError {
  errorCode?: string;
  errorMessage?: string;
  identifier?: string;
  severity?: ValidationSeverity;
}
