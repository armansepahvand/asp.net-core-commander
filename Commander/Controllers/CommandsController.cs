            _mapper.Map(commandUpdateDto, commandModelFromRepo);

            _repository.UpdateCommand(commandModelFromRepo);

            _repository.SaveChanges();

            return NoContent();

        }

